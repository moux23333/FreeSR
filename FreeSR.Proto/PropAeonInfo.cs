namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class PropAeonInfo
	{
		[ProtoMember(6)] public int DialogueGroupId;
		[ProtoMember(15)] public int AeonId;
		[ProtoMember(2)] public int AddExp;
	}

}
