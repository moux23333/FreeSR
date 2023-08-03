namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ExpUpRelicScRsp
	{
		[ProtoMember(10)] public int Retcode;
		[ProtoMember(2)] public List<PileItem> ReturnItemList;
	}
	
}
