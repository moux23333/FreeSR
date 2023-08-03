namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class Mission
	{
		[ProtoMember(15)] public int Id;
		[ProtoMember(1)] public int Progress;
		[ProtoMember(7)] public MissionStatus Status;
	}
	
}
