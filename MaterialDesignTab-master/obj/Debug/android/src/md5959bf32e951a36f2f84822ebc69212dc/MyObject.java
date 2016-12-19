package md5959bf32e951a36f2f84822ebc69212dc;


public class MyObject
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		java.io.Serializable
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("TabbedApp.MyObject, TabbedApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MyObject.class, __md_methods);
	}


	public MyObject () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MyObject.class)
			mono.android.TypeManager.Activate ("TabbedApp.MyObject, TabbedApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
