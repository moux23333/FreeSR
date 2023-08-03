namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SyncRogueFinishScNotify
	{
		[ProtoMember(9)] public RogueFinishInfo FinishInfo;
	}
	
}
