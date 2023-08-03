namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class TutorialGuide
	{
		[ProtoMember(3)] public int Id;
		[ProtoMember(11)] public TutorialStatus Status;
	}
	
}
