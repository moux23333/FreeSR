namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class TutorialGuide
	{
		[ProtoMember(7)] public TutorialStatus Status;
		[ProtoMember(5)] public int Id;
	}

}
