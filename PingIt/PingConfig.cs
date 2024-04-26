using System.Runtime;

namespace PingIt;

public class PingConfig
{
    public enum TargetType {
        Party,
        OtherPlayer,
        NPC,
        Ability,
        Field
    }
    public string name;
    public string chatMsg;
    public TargetType target;

    public PingConfig(string name, TargetType target, string chatMsg) {
        this.name = name;
        this.chatMsg = chatMsg;
        this.target = target;
    }
}