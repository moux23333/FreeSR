namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SavePointsInfoNotify
	{
		[ProtoMember(3)] public int ValidTimes;
		[ProtoMember(10)] public long RefreshTime;
	}
	
}
