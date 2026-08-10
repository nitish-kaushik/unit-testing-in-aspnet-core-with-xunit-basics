<div align="center">

# 🧪 Unit Testing in ASP.NET Core with xUnit

### A Practical, Hands-On Course for Modern .NET Developers

<p>
  <strong>ASP.NET Core</strong> •
  <strong>C#</strong> •
  <strong>.NET 10</strong> •
  <strong>xUnit</strong>
</p>

<br>

<a href="https://www.youtube.com/watch?v=fVVNOkbLcPw&list=PLaFzfwmPR7_LlpcyBEOZBrYpZv3MppZNB">
  <img src="https://img.shields.io/badge/▶%20FREE%20COURSE%20ON%20YOUTUBE-FF0000?style=for-the-badge&logo=youtube&logoColor=white" alt="Free Course on YouTube">
</a>

 

<a href="https://www.udemy.com/course/complete-xunit-testing-aspnet-core-dotnet/?referralCode=33F06E90F242FAE8C502">
  <img src="https://img.shields.io/badge/🎓%20PAID%20COURSE%20ON%20UDEMY-A435F0?style=for-the-badge&logo=udemy&logoColor=white" alt="Paid Course on Udemy">
</a>

<br><br>

<img src="https://img.shields.io/badge/.NET-10-512BD4?style=flat-square&logo=dotnet&logoColor=white" alt=".NET 10">
<img src="https://img.shields.io/badge/C%23-13-239120?style=flat-square&logo=csharp&logoColor=white" alt="C#">
<img src="https://img.shields.io/badge/xUnit-Testing-5E5E5E?style=flat-square" alt="xUnit">

<br><br>

<a href="https://github.com/nitish-kaushik/unit-testing-in-aspnet-core-with-xunit-basics/stargazers">
  <img src="https://img.shields.io/github/stars/nitish-kaushik/unit-testing-in-aspnet-core-with-xunit-basics?style=flat-square" alt="GitHub Stars">
</a>

</div>

---

## 🎯 About This Course

Welcome! 👋

This repository contains the source code and examples for my course:

> **Unit Testing in ASP.NET Core with xUnit**

The goal is simple:

**Learn how to write meaningful, maintainable unit tests for modern ASP.NET Core applications — and understand why you're writing them.**

We'll learn by writing real code, running tests, breaking things, fixing them, and gradually building a strong testing mindset.

This repository is designed to be used **alongside the course**, so you can follow the examples, experiment with the code, and come back to it whenever you need a reference.

---

## 🎥 Learn It FREE on YouTube

The complete course is available **for free on YouTube**.

No subscription.
No paywall.
Just learn. ❤️

<div align="center">

<a href="https://www.youtube.com/watch?v=fVVNOkbLcPw&list=PLaFzfwmPR7_LlpcyBEOZBrYpZv3MppZNB">
  <img src="https://img.shields.io/badge/▶%20WATCH%20THE%20FREE%20COURSE-FF0000?style=for-the-badge&logo=youtube&logoColor=white" alt="Watch Free Course">
</a>

</div>

---

## 🎓 Prefer Udemy?

The course is also available as a **paid course on Udemy**.

If you prefer a structured learning experience and keeping the course in your Udemy library, you can get it here:

<div align="center">

<a href="https://www.udemy.com/course/complete-xunit-testing-aspnet-core-dotnet/?referralCode=33F06E90F242FAE8C502">
  <img src="https://img.shields.io/badge/🎓%20VIEW%20COURSE%20ON%20UDEMY-A435F0?style=for-the-badge&logo=udemy&logoColor=white" alt="Udemy Course">
</a>

</div>

### 💡 YouTube vs Udemy

| 🎥 YouTube                        | 🎓 Udemy                              |
| --------------------------------- | ------------------------------------- |
| 🆓 Completely free                | 💳 Paid                               |
| Video-based learning              | Structured course experience          |
| Accessible to everyone            | Keep the course in your Udemy library |
| Follow along with this repository | Follow along with this repository     |

**Choose whichever works best for you.**

---

# 🧠 What You'll Learn

By the end of this course, you'll have a solid foundation for writing unit tests in ASP.NET Core applications.

---

# 📂 Repository Structure

```text
📦 unit-testing-in-aspnet-core-with-xunit-basics
│
├── 📁 src
│   └── Application source code
│
├── 📁 tests
│   └── Unit test projects
│
├── 📄 README.md
└── 📄 ...
```

> The repository structure may evolve as the course grows.

---

# 🚀 Getting Started

## Prerequisites

Before starting, make sure you have:

* [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
* Basic knowledge of C#
* Basic understanding of ASP.NET Core
* Visual Studio, VS Code, or JetBrains Rider

---

# 🧪 The Testing Mindset

This course isn't just about learning attributes like:

```csharp
[Fact]
```

or:

```csharp
[Theory]
```

It's about learning to ask:

> **"How can I prove that my code behaves correctly?"**

Good testing isn't about writing hundreds of tests just to increase a coverage percentage.

It's about creating **confidence in your code**.

```text
                 Your Code
                    │
                    ▼
              ┌───────────┐
              │   Tests   │
              └─────┬─────┘
                    │
          ┌─────────┴─────────┐
          ▼                   ▼
       Works?              Breaks?
          │                   │
          ▼                   ▼
     Confidence           Fix It 🚀
```

---

# 💡 Why xUnit?

[xUnit](https://xunit.net/) is a popular testing framework in the .NET ecosystem.

Throughout the course, you'll work with concepts such as:

### Facts

```csharp
[Fact]
public void Something_Should_Work()
{
    // Arrange
    // Act
    // Assert
}
```

### Theories

```csharp
[Theory]
[InlineData(1, 2, 3)]
[InlineData(5, 5, 10)]
public void Add_Should_Return_Expected_Result(
    int first,
    int second,
    int expected)
{
    // Arrange
    // Act
    // Assert
}
```

### Assertions

```csharp
Assert.Equal(expected, actual);
```

But the goal isn't to memorize these APIs.

The goal is to understand **when, why, and how to use them effectively**.

---

# 🛠️ Technologies

<div align="center">

<img src="https://skillicons.dev/icons?i=dotnet,cs" alt=".NET and C#">

</div>

<br>

| Technology                    | Purpose                   |
| ----------------------------- | ------------------------- |
| 🟣 **C#**                     | Programming language      |
| 🔷 **.NET 10**                | Application platform      |
| 🌐 **ASP.NET Core**           | Web application framework |
| 🧪 **xUnit**                  | Testing framework         |
| 🎭 **Mocking**                | Isolating dependencies    |
| 🗄️ **Entity Framework Core** | Data access scenarios     |

---

# 👨‍🏫 About Me

<div align="center">

<img src="https://github.com/nitish-kaushik.png" width="120" height="120" alt="Nitish Kaushik">

### Nitish Kaushik

**6× Microsoft MVP • .NET Expert • Full-Time Content Creator**

</div>

I'm a **.NET expert, 6× Microsoft MVP, and full-time content creator** focused on making software development easier to learn.

Through **WebGentle**, my goal is simple:

> **Take complicated development concepts and make them easier to understand through practical examples.**

---

# ❤️ Why is the YouTube Course Free?

A large part of my audience consists of students and developers who are just starting their careers.

Not everyone can afford paid courses.

So I've decided to keep the complete YouTube version **free and accessible to everyone**.

If you prefer Udemy, the paid version is available there as well.

But if you can't afford it, **that's completely okay.**

Use the free YouTube course.
Use this repository.
Build the examples.
Learn something new.

That's what matters. ❤️

---

# 💙 Support My Free Content

If you find my free courses and content useful, you can support my work directly.

<div align="center">

<table>
<tr>

<td align="center" width="50%">

### 🐙 GitHub Sponsors

Support me directly through GitHub.

<br>

<a href="https://github.com/sponsors/nitish-kaushik">
  <img src="https://img.shields.io/badge/Sponsor%20Nitish%20Kaushik-EA4AAA?style=for-the-badge&logo=githubsponsors&logoColor=white" alt="Sponsor Nitish Kaushik">
</a>

</td>

<td align="center" width="50%">

### 🌐 WebGentle Sponsors

Support the WebGentle creator community.

<br>

<a href="https://github.com/sponsors/webgentle">
  <img src="https://img.shields.io/badge/Sponsor%20WebGentle-EA4AAA?style=for-the-badge&logo=githubsponsors&logoColor=white" alt="Sponsor WebGentle">
</a>

</td>

</tr>

<tr>

<td align="center" width="50%">

### 💙 PayPal

Support from anywhere in the world.

<br>

<a href="https://www.paypal.com/paypalme/webgentle">
  <img src="https://img.shields.io/badge/Sponsor%20via%20PayPal-0070BA?style=for-the-badge&logo=paypal&logoColor=white" alt="Sponsor via PayPal">
</a>

</td>

<td align="center" width="50%">

### 🇮🇳 Razorpay

For supporters in India.

<br>

<a href="https://razorpay.me/@webgentle">
  <img src="https://img.shields.io/badge/Sponsor%20via%20Razorpay-0C9E5B?style=for-the-badge" alt="Sponsor via Razorpay">
</a>

</td>

</tr>
</table>

<br>

**Thank you for supporting free developer education. ❤️**

</div>

---

<div align="center">

## 🚀 Keep Learning. Keep Building. Keep Testing.

### Made with ❤️ by Nitish Kaushik

**Microsoft MVP • .NET Expert • Full-Time Content Creator**

<br>

⭐ **If this repository helped you, consider starring it!**

</div>
