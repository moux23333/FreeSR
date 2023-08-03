namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class BattleLineup
	{
		[ProtoMember(1)] public List<BattleAvatar> AvatarList;
		[ProtoMember(2)] public List<CIBACFDGCLK> MonsterWaveList;
		[ProtoMember(3)] public List<BattleBuff> BuffList;
		[ProtoMember(4)] public List<int> AKMCAFABELI;
		[ProtoMember(5)] public List<JBIFJJMLIML> FHDLDLDIFOJ;
		[ProtoMember(6)] public List<GIOMKGLAEHG> HEFBEDPNADM;
		[ProtoMember(7)] public int WorldLevel;
		[ProtoMember(8)] public List<PDPCNJHHAJB> EJPPGOFMDOK;
	}
	
}
