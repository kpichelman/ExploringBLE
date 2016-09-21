package md5ec6fc2756eac100cee2d48a62ded64dd;


public class BLEAdvertiserCallback
	extends android.bluetooth.le.AdvertiseCallback
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("ExploringBLE.BLEAdvertiserCallback, ExploringBLE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", BLEAdvertiserCallback.class, __md_methods);
	}


	public BLEAdvertiserCallback () throws java.lang.Throwable
	{
		super ();
		if (getClass () == BLEAdvertiserCallback.class)
			mono.android.TypeManager.Activate ("ExploringBLE.BLEAdvertiserCallback, ExploringBLE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public BLEAdvertiserCallback (md5ec6fc2756eac100cee2d48a62ded64dd.MainActivity p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == BLEAdvertiserCallback.class)
			mono.android.TypeManager.Activate ("ExploringBLE.BLEAdvertiserCallback, ExploringBLE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "ExploringBLE.MainActivity, ExploringBLE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", this, new java.lang.Object[] { p0 });
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
