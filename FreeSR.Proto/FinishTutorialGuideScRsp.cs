namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class FinishTutorialGuideScRsp
	{
		[ProtoMember(4)] public ItemList Reward;
		[ProtoMember(3)] public TutorialGuide TutorialGuide;
		[ProtoMember(13)] public int Retcode;
	}
	
}
