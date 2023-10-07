namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class PunkLordBattleReplay
	{
		[ProtoMember(1)] public string BattleReplayKey;
		[ProtoMember(2)] public KIBOFBCJCCI ReplayInfo;
	}

}
