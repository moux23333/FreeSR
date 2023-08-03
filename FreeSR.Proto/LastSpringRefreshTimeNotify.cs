namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class LastSpringRefreshTimeNotify
	{
		[ProtoMember(7)] public long LastTime;
	}
	
}
