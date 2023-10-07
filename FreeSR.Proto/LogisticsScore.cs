namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class LogisticsScore
	{
		[ProtoMember(14)] public ItemList Reward;
		[ProtoMember(12)] public int CurScore;
		[ProtoMember(13)] public int LastLevel;
		[ProtoMember(4)] public int LastMaxScore;
		[ProtoMember(1)] public int MapId;
		[ProtoMember(8)] public int MaxScore;
		[ProtoMember(15)] public int UnlockLevel;
	}

}
