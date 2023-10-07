namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class Mission
	{
		[ProtoMember(15)] public int Id;
		[ProtoMember(14)] public int Progress;
		[ProtoMember(8)] public MissionStatus Status;
	}

}
