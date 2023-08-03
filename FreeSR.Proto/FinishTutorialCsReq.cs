namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class FinishTutorialCsReq
	{
		[ProtoMember(1)] public int TutorialId;
	}
	
}
