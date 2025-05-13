using System;
using System.Collections;
using System.Collections.Generic;

namespace POEPart1
{
    internal class getFacts
    {

        //Method for getting the facts
        public void gettingFacts(Dictionary<string, List<string>> topicResponses)
        {

            topicResponses["how are you"] = new List<string>
            {
                "Im good thank you"
            };
            topicResponses["purpose"] = new List<string>
            {
                "To teach you about cybersecurity"
            };
            topicResponses["ask"] = new List<string>
            {
                "You can ask me about how you can create Strong passwords, what is a password, about Password's safety, What is Phishing and how to recognize a Phishing email, two factor authentication,cybersecurity, cyberattacks, antiviruses, and alot more."
            };
            topicResponses["strong password"] = new List<string>
            {
                "A strong password is one that is hard for other people to guess. It usually has a mix of big letters, small letters, numbers, and symbols.",
                "A strong password uses a combination of uppercase and lowercase letters, numbers, and special characters, is at least 12 characters long, and avoids common words or patterns. It reduces the chances of being cracked by brute force or dictionary attacks.",
                "A strong password is like a super-strong lock on your door—it keeps out unwanted people. The more complex and unique the lock (password), the harder it is for a thief (hacker) to break in.",
                "In cybersecurity, a strong password is essential for protecting accounts and data. It ensures your digital identity is less vulnerable to attacks like credential stuffing, phishing, or password guessing.",
                "A password is strong if it:\n-Has at least 12 characters\n-Includes UPPER and lower case letters\n-Contains numbers (123...)\n-Uses symbols (!@#...)\n-Is unique and not reused across multiple sites"
            };
            topicResponses["password safety"] = new List<string>
            {
                "Password safety means keeping your passwords private and using them in a smart way so that no one else can access your accounts.",
                "Password safety refers to best practices for creating, storing, and managing passwords securely. This includes using strong, unique passwords for each account, enabling two-factor authentication (2FA), and avoiding password reuse or insecure storage (e.g., not writing them down or saving them in plain text).",
                "Password safety is like keeping your house keys safe—don’t leave them lying around, don’t use the same key for every door, and don’t give copies to people you don’t trust.",
                "From a cybersecurity point of view, password safety is essential for protecting systems and user data. Poor password safety leads to breaches, identity theft, and unauthorized access to sensitive information.",
                "To practice good password safety:\n-Don’t share your passwords\n-Don’t write passwords down where others can find them\n-Use a different password for each account\n-Use a password manager to store them securely\n-Turn on two-factor authentication (2FA) when available"
            };
            topicResponses["phishing"] = new List<string>
            {
                "Phishing is when someone pretends to be someone you trust (like a bank or company) to trick you into giving them your personal information, like passwords or bank details.",
                "Phishing is a type of cyberattack where attackers use fake emails, messages, or websites to trick users into revealing sensitive information such as login credentials, credit card numbers, or personal data. These attacks often rely on social engineering and can lead to identity theft or system compromise.",
                "Phishing is like a scammer sending a fake letter pretending to be your bank, asking for your PIN. If you fall for it, you’re handing the keys to your money. The same happens online, through fake emails and websites.",
                "In cybersecurity, phishing is one of the most common and dangerous threats. It exploits human trust rather than software weaknesses, making user awareness and caution key defenses. Even well-protected systems can be breached if a user clicks a malicious link or attachment.",
                "To spot and avoid phishing:\n-Check the sender’s email address carefully\n-Don’t click suspicious links or download unexpected attachments\n-Look for spelling or grammar mistakes\n-Be cautious of messages asking for personal info\n-Verify requests directly with the source (e.g., call your bank)"
            };
            topicResponses["two-factor authentication"] = new List<string>
            {
                "Two-factor authentication means using two ways to prove it's really you when logging into an account—like a password and a code sent to your phone.",
                "Two-factor authentication (2FA) is a security process that requires users to verify their identity using two different types of credentials:\n1) Something you know (like a password)\n2) Something you have (like a phone or authentication app) or something you are (like a fingerprint).\nThis adds an extra layer of protection even if your password is stolen.",
                "2FA is like unlocking a door with both a key and a fingerprint scanner. Even if someone has your key (password), they still can't get in without the second step.",
                "From a security standpoint, 2FA significantly reduces the risk of unauthorized access. Even if attackers get your password through phishing or leaks, they still can't log in without the second factor—making it a powerful defense against account compromise.",
                "Good examples of 2FA:\n-Password + a code sent by SMS\n-Password + code from an authentication app (like Google Authenticator)\n-Password + fingerprint or face scan\n-Always enable 2FA on accounts that support it\n-Avoid relying on SMS if possible—use an app-based method for better security"
            };
            topicResponses["password"] = new List<string>
            {
                "A password is a secret word or code you use to get into your accounts, like your phone, email, or online banking.",
                "A password is a string of characters (letters, numbers, and symbols) used to authenticate a user’s identity and grant access to a system, application, or service. It acts as the first layer of defense in protecting digital information.",
                "A password is like the key to your house. If someone has it, they can get inside. That’s why it needs to be strong, secret, and not shared with others.",
                "In cybersecurity, a password is a critical security credential. Weak or reused passwords are one of the top causes of security breaches, making good password practices essential to protecting systems and personal data.",
                "A good password:\n-Unlocks your private information\n-Should be kept secret\n-Should be strong (not easy to guess)\n-Should be different for each account\n-Should be changed if you think it’s been exposed"
            };
            topicResponses["cybersecurity"] = new List<string>
            {
                "Cybersecurity means protecting computers, phones, and the internet from hackers, viruses, and people who try to steal information.",
                "Cybersecurity is the practice of protecting systems, networks, and digital data from unauthorized access, attacks, or damage. It includes technologies, processes, and controls that secure information confidentiality, integrity, and availability.",
                "Cybersecurity is like a security system for your digital world—just like locks, alarms, and cameras protect your home, cybersecurity tools and practices protect your devices and data online.",
                "From a professional standpoint, cybersecurity is essential in today's connected world to prevent data breaches, financial loss, identity theft, and disruption of services. It covers areas like network security, application security, and user awareness.",
                "Cybersecurity involves:\n-Using strong passwords and 2FA\n-Keeping software up to date\n-Avoiding suspicious emails and links\n-Installing antivirus and firewall protection\n-Learning how to recognize cyber threats"
            };
            topicResponses["cyberattack"] = new List<string>
            {
                "A cyberattack is when someone tries to break into a computer or network to steal, damage, or mess with information.",
                "A cyberattack is a deliberate attempt by hackers or cybercriminals to breach the security of a computer system, network, or digital device. The goal may be to steal data, disrupt operations, spy on users, or take control of systems. Common types include malware, phishing, denial-of-service (DoS), and ransomware.",
                "A cyberattack is like a thief breaking into a building, but instead of using a crowbar, they use code and tricks to get into your digital systems and steal or damage your files.",
                "In cybersecurity, cyberattacks are serious threats that can cause data breaches, financial loss, reputational damage, and even endanger public safety. Organizations defend against cyberattacks using firewalls, encryption, intrusion detection systems, and employee awareness training.",
                "Cyberattacks can:\n-Steal personal or business information\n-Shut down websites or networks (DoS attacks)\n-Trick users into giving up login details (phishing)\n-Lock files and demand money (ransomware)\n-Be launched by individuals, groups, or even governments"
            };
            topicResponses["antivirus"] = new List<string>
            {
                "Antivirus is a program that protects your computer from viruses and other bad software that can harm it or steal your information.",
                "Antivirus software is a security application designed to detect, prevent, and remove malicious software (malware), including viruses, worms, Trojans, ransomware, spyware, and more. It works by scanning files and programs for known threats and suspicious behavior.",
                "An antivirus is like a security guard for your computer. It checks every file or program trying to get in, stops dangerous ones, and removes anything that could cause harm.",
                "From a cybersecurity standpoint, antivirus is one part of a layered defense strategy. While it's effective at blocking known threats, modern cybersecurity also includes firewalls, updates, backups, and user awareness to defend against newer and more complex attacks.",
                "Antivirus helps you by:\n-Scanning your computer for threats\n-Blocking viruses and malware in real-time\n-Removing harmful files safely\n-Keeping itself updated with the latest virus definitions\n-Running scheduled scans to keep your system clean"
            };
            topicResponses["ip"] = new List<string>
            {
                "An IP address is like your home address on the internet. It tells other devices where to find you or send information.",
                "An IP (Internet Protocol) address is a numerical label assigned to each device connected to a computer network that uses the Internet Protocol. It serves two main functions: identifying the host or network interface and providing the location of the device in the network (routing).",
                "Think of an IP address like a phone number or street address. Just as the postal service uses your home address to deliver letters, the internet uses IP addresses to send and receive data between devices.",
                "From a cybersecurity view, IP addresses are critical for tracking connections, blocking threats, and enforcing network policies. Attackers can use or spoof IPs to hide identity or perform attacks, while defenders monitor IP traffic to detect suspicious activity.",
                "IP address facts:\n-Every device online has an IP address\n-It can be IPv4 (e.g., 192.168.1.1) or IPv6 (e.g., 2001:0db8::1)\n-Used to send/receive data over the internet\n-Can be static (unchanging) or dynamic (changes over time)\n-Public IPs are visible online; private IPs are used within local networks"
            };
            topicResponses["safe browsing"] = new List<string>
            {
                "Safe browsing means using the internet carefully so you don’t get viruses, fall for scams, or give your information to the wrong people.",
                "Safe browsing refers to following best practices and using tools to minimize security risks while navigating the internet. This includes avoiding malicious websites, not clicking suspicious links, keeping your browser updated, and using secure (HTTPS) connections to protect data in transit.",
                "Safe browsing is like wearing a seatbelt while driving online—you follow traffic rules (like not clicking strange links), avoid bad neighborhoods (dangerous websites), and keep your car (browser) in good condition (updated and protected).",
                "From a cybersecurity perspective, safe browsing is a key part of defending against malware, phishing attacks, and data leaks. It combines user awareness with security tools (like browser extensions, ad blockers, and HTTPS enforcement) to create a safer online experience.",
                "Safe browsing tips:\n-Only visit trusted and secure websites (look for HTTPS)\n-Don’t click on pop-ups or suspicious links\n-Keep your browser and antivirus updated\n-Don’t enter personal info on unfamiliar sites\n-Use privacy tools like ad blockers and anti-tracking extensions"
            };
            topicResponses["privacy"] = new List<string>
            {
                "Privacy means keeping your personal information safe and only sharing it with people you trust.",
                "In the digital world, privacy refers to the right and ability of users to control how their personal data is collected, used, shared, and stored. It includes protecting things like names, addresses, passwords, photos, and online activity from unauthorized access or exposure.",
                "Think of privacy like closing the curtains in your house—you choose who can see inside and what you want to keep hidden. Online, it's about choosing who gets to see your information and how much they know about you.",
                "From a cybersecurity view, privacy is about ensuring that user data is protected and only accessed by authorized individuals. Privacy is supported through encryption, access controls, data minimization, and legal compliance (like POPIA or GDPR).",
                "How to protect your privacy online:\n-Don’t overshare personal info on social media\n-Use strong passwords and 2FA\n-Use private or incognito mode when needed\n-Check app and website privacy settings\n-Be careful about what permissions you give apps"
            };
            topicResponses["malware"] = new List<string>
            {
                "Malware is bad software that can harm your computer, steal your information, or mess things up.",
                "Malware (short for malicious software) refers to any software intentionally designed to cause damage to computers, networks, or users. Types of malware include viruses, worms, trojans, ransomware, spyware, adware, and rootkits.",
                "Malware is like a disease for your computer. Just like germs can make you sick, malware can infect your device and make it slow, steal your info, or stop it from working.",
                "In cybersecurity, malware is a major threat used in cyberattacks to steal data, demand ransom, spy on users, or take control of systems. Protecting against malware requires antivirus software, firewalls, regular updates, and user awareness.",
                "Common types of malware:\n-Virus – spreads by attaching to files\n-Worm – spreads without help from the user\n-Trojan – looks safe but is harmful\n-Ransomware – locks your files and demands payment\n-Spyware – secretly watches what you do\n\nTo stay safe:\n-Don’t download from unknown sources\n-Keep antivirus and software updated\n-Avoid clicking suspicious links or attachments"
            };
            topicResponses["social engineering"] = new List<string>
            {
                "Social engineering is when someone tricks you into giving away your personal information, like passwords or bank details.",
                "Social engineering is a manipulation technique used by attackers to deceive people into revealing confidential information or performing actions that compromise security. It exploits human psychology rather than technical weaknesses, often through emails, phone calls, or in-person interactions.",
                "Social engineering is like a con artist pretending to be a police officer to make you hand over your keys. Online, they pretend to be someone you trust—like your boss or your bank—to get sensitive info.",
                "From a cybersecurity viewpoint, social engineering is one of the most dangerous attack methods because it targets human behavior. Even well-secured systems can be breached if someone is tricked into giving up their login credentials or clicking a malicious link.",
                "Common forms of social engineering:\n-Phishing – fake emails or messages asking for info\n-Vishing – scam phone calls pretending to be official\n-Smishing – text messages with dangerous links\n-Impersonation – pretending to be someone else in person or online\n\nTo protect yourself:\n-Don’t trust unexpected requests for personal info\n-Always verify before clicking or responding\n-Stay cautious, even if a message looks official"
            };
        }

        public void defaultResponses(List<string> defaults)
        {
            defaults.Add("I'm not sure I understand. Could you rephrase?");
            defaults.Add("Can you provide more details?");
            defaults.Add("Let's talk more about cybersecurity!");
        }
    }
}