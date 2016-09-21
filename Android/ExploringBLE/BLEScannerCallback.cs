using System.Collections.Generic;
using Android.Bluetooth.LE;

namespace ExploringBLE
{
	public class BLEScannerCallback : ScanCallback
	{
		MainActivity _parent;


		public BLEScannerCallback(MainActivity mainActivity)
		{
			_parent = mainActivity;
		}

		void onBatchScanResults(List<ScanResult> results)
		{
			_parent.UpdateTextView("Found " + results.Count + " Items!");
		}

		void onScanFailed(int errorCode)
		{
			_parent.UpdateTextView("Scan Failed.  Code: " + errorCode);
		}

		void onScanResult(int callbackType, ScanResult result)
		{
			_parent.UpdateTextView("Results - callbackType: " + callbackType + " results: " + result.Device.Name);
		}
	}
}
