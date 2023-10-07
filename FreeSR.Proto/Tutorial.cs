namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class Tutorial
	{
		[ProtoMember(9)] public TutorialStatus Status;
		[ProtoMember(14)] public int Id;
	}

}
