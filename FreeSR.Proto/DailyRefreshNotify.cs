namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class DailyRefreshNotify
	{
		[ProtoMember(12)] public int CurDay;
	}
	
}
