namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetTutorialGuideScRsp
	{
		[ProtoMember(8)] public List<TutorialGuide> TutorialGuideList;
		[ProtoMember(4)] public int Retcode;
	}

}
