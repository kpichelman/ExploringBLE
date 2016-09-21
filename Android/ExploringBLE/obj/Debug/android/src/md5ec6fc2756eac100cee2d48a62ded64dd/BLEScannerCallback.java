package md5ec6fc2756eac100cee2d48a62ded64dd;


public class BLEScannerCallback
	extends android.bluetooth.le.ScanCallback
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("ExploringBLE.BLEScannerCallback, ExploringBLE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", BLEScannerCallback.class, __md_methods);
	}


	public BLEScannerCallback () throws java.lang.Throwable
	{
		super ();
		if (getClass () == BLEScannerCallback.class)
			mono.android.TypeManager.Activate ("ExploringBLE.BLEScannerCallback, ExploringBLE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public BLEScannerCallback (md5ec6fc2756eac100cee2d48a62ded64dd.MainActivity p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == BLEScannerCallback.class)
			mono.android.TypeManager.Activate ("ExploringBLE.BLEScannerCallback, ExploringBLE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "ExploringBLE.MainActivity, ExploringBLE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", this, new java.lang.Object[] { p0 });
	}

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
