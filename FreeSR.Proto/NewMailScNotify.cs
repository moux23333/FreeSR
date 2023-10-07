namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class NewMailScNotify
	{
		[ProtoMember(12)] public List<int> MailIdList;
	}

}
