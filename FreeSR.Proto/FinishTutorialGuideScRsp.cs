namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class FinishTutorialGuideScRsp
	{
		[ProtoMember(12)] public int Retcode;
		[ProtoMember(3)] public TutorialGuide TutorialGuide;
		[ProtoMember(1)] public ItemList Reward;
	}

}
