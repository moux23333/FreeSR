namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class FightActivityDataChangeScNotify
	{
		[ProtoMember(9)] public Dictionary<int, int> PBBDAKADPBM;
		[ProtoMember(12)] public List<FightActivityGroup> DGCKLECLBND;
	}
	
}
