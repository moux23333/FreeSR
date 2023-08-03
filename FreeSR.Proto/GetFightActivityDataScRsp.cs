namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetFightActivityDataScRsp
	{
		[ProtoMember(8)] public bool IANHEHHMGIF;
		[ProtoMember(14)] public List<FightActivityGroup> DGCKLECLBND;
		[ProtoMember(6)] public Dictionary<int,int> PBBDAKADPBM;
		[ProtoMember(4)] public int Retcode;
		[ProtoMember(12)] public int WorldLevel;
	}
	
}
