namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetMailScRsp
	{
		[ProtoMember(11)] public int TotalNum;
		[ProtoMember(4)] public List<ClientMail> MailList;
		[ProtoMember(3)] public int Retcode;
		[ProtoMember(12)] public List<ClientMail> NoticeMailList;
		[ProtoMember(6)] public int Start;
		[ProtoMember(10)] public bool IsEnd;
	}

}
