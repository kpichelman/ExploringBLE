using Android.App;
using Android.Content;
using Android.Widget;
using Android.OS;
using Android.Bluetooth;
using System.Threading.Tasks;
using System.Collections.Generic;
using Android.Bluetooth.LE;

namespace ExploringBLE
{
	[Activity (Label = "ExploringBLE", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;
		protected BluetoothManager _manager;
		protected BluetoothAdapter _adapter;
		protected BluetoothLeScanner _scanner;
		//	protected GattCallback _gattCallback;
		BLEScannerCallback _scannerCallback;
		List<BluetoothDevice> _discoveredDevices;
		protected bool _isScanning = false;
		protected bool _isAdvertizing = false;
		protected TextView _textView;
		protected ListView _listView;
		protected BluetoothLeAdvertiser _advertiser;
		protected BLEAdvertiserCallback _advertiserCallback;
		public static ParcelUuid THERM_SERVICE = ParcelUuid.FromString("00001809-0000-1000-8000-00805f9b34fb");

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Main);
			Context appContext = Android.App.Application.Context;
			_manager = (BluetoothManager)appContext.GetSystemService("bluetooth");
			_adapter = _manager.Adapter;
			//		_gattCallback = new GattCallback(this);
			_scanner = _adapter.BluetoothLeScanner;
			_scannerCallback = new BLEScannerCallback(this);
			_textView = FindViewById<TextView>(Resource.Id.textView);
			_advertiser = _adapter.BluetoothLeAdvertiser;
			Button button = FindViewById<Button> (Resource.Id.button);
			
			button.Click += delegate {
				button.Text = string.Format ("{0} clicks!", count++);
				if (!_isScanning)
				{
					Task.Run(async () =>
					{
						await BeginScanningForDevices();
					});

				}
				else {
					StopScanningForDevices();
				}

			};

			_advertiserCallback = new BLEAdvertiserCallback(this);
			Button button2 = FindViewById<Button>(Resource.Id.button2);
			button2.Click += (sender, e) =>
			{
				if (!_isAdvertizing)
				{
					AdvertiseSettings settings = new AdvertiseSettings.Builder()
					                .SetAdvertiseMode(AdvertiseMode.Balanced)
									.SetConnectable(true)
									.SetTimeout(0)
					                .SetTxPowerLevel(AdvertiseTx.PowerMedium)
									.Build();
					
					AdvertiseData data = new AdvertiseData.Builder()
									.SetIncludeDeviceName(true)
									.SetIncludeTxPowerLevel(true)
									.AddServiceUuid(THERM_SERVICE)
									//.AddServiceData(THERM_SERVICE, buildTempPacket())
									.Build();

					_advertiser.StartAdvertising(settings, data, _advertiserCallback);
					button2.Text = "Stop Advertizing";
					UpdateTextView("Advertizing");
					_isAdvertizing = true;
				}
				else {
					_advertiser.StopAdvertising(_advertiserCallback);
					button2.Text = "Start Advertizing";
					UpdateTextView("Stopped Advertizing");
					_isAdvertizing = false;
				}
			};

			_listView = FindViewById<ListView>(Resource.Id.listView1);
			_listView.ItemClick += (object sender, AdapterView.ItemClickEventArgs e) =>
			{
				UpdateTextView("ListView clicked item, Id: " + e.Id + " Pos: " + e.Position);
			};

			UpdateTextView("OnCreate Complete");
		}
		public void UpdateTextView(string text)
		{
			RunOnUiThread(() =>
			{
				_textView.Text = text + "\n" + _textView.Text;
			});
		}



		public async Task BeginScanningForDevices()
		{
			UpdateTextView("BluetoothLEManager: Starting a scan for devices.");
			_isScanning = true;
			_discoveredDevices = new List<BluetoothDevice>();
			_scanner.StartScan(_scannerCallback);
			await Task.Delay(10000);
			StopScanningForDevices();
		}

		public void StopScanningForDevices()
		{
			UpdateTextView("BluetoothLEManager: Stopping the scan for devices.");
			_isScanning = false;
			_scanner.StopScan(_scannerCallback);
		}
	}
}


