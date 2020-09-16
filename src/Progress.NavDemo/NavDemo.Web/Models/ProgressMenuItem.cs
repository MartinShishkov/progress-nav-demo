using System;

namespace NavDemo.Web.Models
{
    public class ProgressMenuItem
    {
        public ProgressMenuItem(int id, string text, ProgressMenuItem[] children = null)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(text));
            Children = children ?? new ProgressMenuItem[0];
            Id = id;
            Text = text;
        }

        public ProgressMenuItem[] Children { get; }

        public int Id { get; }

        public string Text { get; }

        public bool HasChildren => Children.Length > 0;
    }
}