namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ComposeItemScRsp
	{
		[ProtoMember(1)] public int Retcode;
		[ProtoMember(4)] public int ComposeId;
		[ProtoMember(5)] public int Count;
		[ProtoMember(9)] public ItemList ReturnItemList;
	}
	
}
