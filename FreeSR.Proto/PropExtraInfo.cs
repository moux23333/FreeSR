namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class PropExtraInfo
	{
		[ProtoMember(4)] public PropRogueInfo RogueInfo;
		[ProtoMember(15)] public PropAeonInfo AeonInfo;
	}
	
}
