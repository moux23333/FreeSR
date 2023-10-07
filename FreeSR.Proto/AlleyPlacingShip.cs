namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class AlleyPlacingShip
	{
		[ProtoMember(5)] public int ShipId;
		[ProtoMember(9)] public List<EIHNLGCGHNI> GoodsList;
	}

}
