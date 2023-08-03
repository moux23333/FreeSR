namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ComposeSelectedRelicScRsp
	{
		[ProtoMember(5)] public ItemList ReturnItemList;
		[ProtoMember(12)] public int ComposeId;
		[ProtoMember(13)] public int Retcode;
	}
	
}
