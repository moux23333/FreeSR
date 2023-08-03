namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ClientTurnSnapshot
	{
		[ProtoMember(1)] public int CDHBKMOCEAD;
		[ProtoMember(2)] public BattleEventProperty Status;
		[ProtoMember(3)] public List<LKLPOEPPEHP> OCCBKAINDCD;
	}
	
}
