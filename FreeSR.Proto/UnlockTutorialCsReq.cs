namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class UnlockTutorialCsReq
	{
		[ProtoMember(1)] public int TutorialId;
	}
	
}
