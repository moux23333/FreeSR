namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ExpUpEquipmentScRsp
	{
		[ProtoMember(13)] public int Retcode;
		[ProtoMember(1)] public List<PileItem> ReturnItemList;
	}
	
}
