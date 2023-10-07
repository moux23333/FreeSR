namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SavePointsInfoNotify
	{
		[ProtoMember(2)] public int RefreshTime;
		[ProtoMember(10)] public int ValidTimes;
	}

}
