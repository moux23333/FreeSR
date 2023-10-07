namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class BattleMonster
	{
		[ProtoMember(1)] public int MonsterId;
		[ProtoMember(2)] public int CurHp;
		[ProtoMember(3)] public int MaxHp;
	}

}
