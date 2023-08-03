namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class PropAeonInfo
	{
		[ProtoMember(4)] public int AddExp;
		[ProtoMember(10)] public int DialogueGroupId;
		[ProtoMember(8)] public int AeonId;
	}
	
}
