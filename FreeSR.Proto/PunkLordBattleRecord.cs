namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class PunkLordBattleRecord
	{
		[ProtoMember(1)] public int Uid;
		[ProtoMember(2)] public int DamageHp;
		[ProtoMember(3)] public bool IsFinalHit;
		[ProtoMember(4)] public int OverKillDamageHp;
		[ProtoMember(5)] public string BattleReplayKey;
		[ProtoMember(6)] public List<PunkLordBattleAvatar> AvatarList;
		[ProtoMember(7)] public int AssistScore;
		[ProtoMember(8)] public int DamageScore;
		[ProtoMember(9)] public int FinalHitScore;
	}

}
