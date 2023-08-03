namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SellItemScRsp
	{
		[ProtoMember(7)] public int Retcode;
		[ProtoMember(5)] public ItemList ReturnItemList;
	}
	
}
