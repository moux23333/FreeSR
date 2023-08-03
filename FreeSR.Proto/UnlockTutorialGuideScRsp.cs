namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class UnlockTutorialGuideScRsp
	{
		[ProtoMember(8)] public TutorialGuide TutorialGuide;
		[ProtoMember(10)] public int Retcode;
	}
	
}
