package md5ec6fc2756eac100cee2d48a62ded64dd;


public class GattCallback
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.bluetooth.BluetoothAdapter.LeScanCallback
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onLeScan:(Landroid/bluetooth/BluetoothDevice;I[B)V:GetOnLeScan_Landroid_bluetooth_BluetoothDevice_IarrayBHandler:Android.Bluetooth.BluetoothAdapter/ILeScanCallbackInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("ExploringBLE.GattCallback, ExploringBLE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", GattCallback.class, __md_methods);
	}


	public GattCallback () throws java.lang.Throwable
	{
		super ();
		if (getClass () == GattCallback.class)
			mono.android.TypeManager.Activate ("ExploringBLE.GattCallback, ExploringBLE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public GattCallback (md5ec6fc2756eac100cee2d48a62ded64dd.MainActivity p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == GattCallback.class)
			mono.android.TypeManager.Activate ("ExploringBLE.GattCallback, ExploringBLE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "ExploringBLE.MainActivity, ExploringBLE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", this, new java.lang.Object[] { p0 });
	}


	public void onLeScan (android.bluetooth.BluetoothDevice p0, int p1, byte[] p2)
	{
		n_onLeScan (p0, p1, p2);
	}

	private native void n_onLeScan (android.bluetooth.BluetoothDevice p0, int p1, byte[] p2);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
