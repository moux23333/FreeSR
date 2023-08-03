namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class NewMailScNotify
	{
		[ProtoMember(5)] public List<int> MailIdList;
	}
	
}
