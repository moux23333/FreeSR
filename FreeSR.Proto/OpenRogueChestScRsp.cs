namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class OpenRogueChestScRsp
	{
		[ProtoMember(7)] public int Retcode;
		[ProtoMember(8)] public ItemList Reward;
		[ProtoMember(2)] public ItemList ExtraDropData;
	}
	
}
