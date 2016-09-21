using Android.Bluetooth.LE;

namespace ExploringBLE
{
	public class BLEAdvertiserCallback : AdvertiseCallback
	{
		MainActivity _parent;

		public BLEAdvertiserCallback(MainActivity parent)
		{
			_parent = parent;
			_parent.UpdateTextView("BLEAdvertiserCallback Constructed");
		}

		protected void OnStartFailure(AdvertiseFailure failure)
		{
			_parent.UpdateTextView("Failed to start advertising: " + failure.ToString());
		}

		protected void OnStartSuccess(AdvertiseSettings settings)
		{
			_parent.UpdateTextView("Started Advertising: " + settings.ToString());
		}
	}
}
