using System;
using Android.Bluetooth;

namespace ExploringBLE
{
	public class GattCallback : Java.Lang.Object, BluetoothAdapter.ILeScanCallback
	{
		protected MainActivity _parent;

		public GattCallback(MainActivity parent)
		{
			_parent = parent;
		}


		public void OnLeScan(BluetoothDevice device, int rssi, byte[] scanRecord)
		{
			_parent.UpdateTextView("Found one!");
			_parent.UpdateTextView("Device: " + device.Name + " Address: " + device.Address + " rssi: " + rssi + "\n");
		}
	}
}