namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class EnterTreasureDungeonCsReq
	{
		[ProtoMember(14)] public List<LBMCPAEPJDC> AvatarList;
		[ProtoMember(9)] public int MNACAFOIAFH;
	}
	
}
