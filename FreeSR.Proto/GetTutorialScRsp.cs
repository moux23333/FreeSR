namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetTutorialScRsp
	{
		[ProtoMember(7)] public List<Tutorial> TutorialList;
		[ProtoMember(15)] public int Retcode;
	}

}
