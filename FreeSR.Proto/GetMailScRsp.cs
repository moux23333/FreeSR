namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetMailScRsp
	{
		[ProtoMember(1)] public List<ClientMail> MailList;
		[ProtoMember(5)] public int TotalNum;
		[ProtoMember(7)] public int Start;
		[ProtoMember(6)] public bool IsEnd;
		[ProtoMember(9)] public List<ClientMail> NoticeMailList;
		[ProtoMember(10)] public int Retcode;
	}
	
}
