namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetTutorialGuideScRsp
	{
		[ProtoMember(9)] public int Retcode;
		[ProtoMember(6)] public List<TutorialGuide> TutorialGuideList;
	}
	
}
