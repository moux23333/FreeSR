namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class UnlockTutorialGuideScRsp
	{
		[ProtoMember(11)] public int Retcode;
		[ProtoMember(8)] public TutorialGuide TutorialGuide;
	}

}
