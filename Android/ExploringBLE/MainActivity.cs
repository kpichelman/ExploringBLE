using Android.App;
using Android.Content;
using Android.Widget;
using Android.OS;
using Android.Bluetooth;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ExploringBLE
{
	[Activity (Label = "ExploringBLE", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;
		protected BluetoothManager _manager;
		protected BluetoothAdapter _adapter;
		protected GattCallback _gattCallback;
		List<BluetoothDevice> _discoveredDevices;
		protected bool _isScanning = false;
		protected TextView _textView;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Main);
			Context appContext = Android.App.Application.Context;
			_manager = (BluetoothManager)appContext.GetSystemService("bluetooth");
			_adapter = this._manager.Adapter;
			_gattCallback = new GattCallback(this);
			_textView = FindViewById<TextView>(Resource.Id.textView);
			Button button = FindViewById<Button> (Resource.Id.button);
			
			button.Click += delegate {
				button.Text = string.Format ("{0} clicks!", count++);
				if (_isScanning)
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
			this._discoveredDevices = new List<BluetoothDevice>();
			_adapter.StartLeScan(_gattCallback);
			await Task.Delay(10000);
			StopScanningForDevices();
		}

		public void StopScanningForDevices()
		{
			UpdateTextView("BluetoothLEManager: Stopping the scan for devices.");
			_isScanning = false;
			this._adapter.StopLeScan(_gattCallback);
		}
	}
}


