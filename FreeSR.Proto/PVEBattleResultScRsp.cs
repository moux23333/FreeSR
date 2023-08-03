namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class PVEBattleResultScRsp
	{
		[ProtoMember(6)] public int FGHNCMKHHNJ;
		[ProtoMember(2)] public ItemList CLHNFINJACO;
		[ProtoMember(13)] public int Retcode;
		[ProtoMember(7)] public int StageId;
		[ProtoMember(4)] public string ANOCKCEFLFP;
		[ProtoMember(3)] public bool CheckIdentical;
		[ProtoMember(9)] public int GGPNCJDCIEK;
		[ProtoMember(5)] public ItemList ExtraDropData;
		[ProtoMember(1)] public int EventId;
		[ProtoMember(8)] public List<BattleAvatar> BattleAvatarList;
		[ProtoMember(14)] public string PGAHMINFDEF;
		[ProtoMember(11)] public int HLBOMGGMBMK;
		[ProtoMember(15)] public ItemList AHBLPMNCEKN;
		[ProtoMember(10)] public int BattleId;
		[ProtoMember(12)] public BattleEndStatus EndStatus;
	}
	
}
