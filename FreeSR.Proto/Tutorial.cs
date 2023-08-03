namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class Tutorial
	{
		[ProtoMember(14)] public int Id;
		[ProtoMember(3)] public TutorialStatus Status;
	}
	
}
