namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class DialogueResultInfo
	{
		[ProtoMember(9)] public ItemList ItemResult;
		[ProtoMember(3)] public RogueBuffList BuffList;
		[ProtoMember(2)] public int DialogueEventId;
	}
	
}
