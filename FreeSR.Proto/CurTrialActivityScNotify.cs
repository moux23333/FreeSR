namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class CurTrialActivityScNotify
	{
		[ProtoMember(4)] public ONBLOKGNJOG Status;
		[ProtoMember(6)] public int EONOLLBLAFM;
	}
	
}
