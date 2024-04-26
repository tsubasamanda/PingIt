using System;
using System.Numerics;
using Dalamud.Interface.Internal;
using Dalamud.Interface.Windowing;
using ImGuiNET;

namespace PingIt.Windows;

public class MainWindow : Window, IDisposable
{
    private Plugin Plugin;

    public MainWindow(Plugin plugin) : base(
        "PingIt Config", 0)
    {
        this.SizeConstraints = new WindowSizeConstraints
        {
            MinimumSize = new Vector2(375, 330),
            MaximumSize = new Vector2(float.MaxValue, float.MaxValue)
        };

        this.Plugin = plugin;
    }

    public void Dispose()
    {
        
    }

    public override void Draw()
    {
        PingConfig config = new PingConfig("Ability Cooldown", PingConfig.TargetType.Ability, "");
        ImGui.BeginTable("config_list", 3);
        ImGui.Text(config.name);
        ImGui.NextColumn();
        ImGui.Text(config.chatMsg);
        ImGui.TableNextRow();
        ImGui.EndTable();
    }
}
