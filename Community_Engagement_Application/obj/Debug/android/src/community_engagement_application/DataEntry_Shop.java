package community_engagement_application;


public class DataEntry_Shop
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Community_Engagement_Application.DataEntry_Shop, Community_Engagement_Application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", DataEntry_Shop.class, __md_methods);
	}


	public DataEntry_Shop () throws java.lang.Throwable
	{
		super ();
		if (getClass () == DataEntry_Shop.class)
			mono.android.TypeManager.Activate ("Community_Engagement_Application.DataEntry_Shop, Community_Engagement_Application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	java.util.ArrayList refList;
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
