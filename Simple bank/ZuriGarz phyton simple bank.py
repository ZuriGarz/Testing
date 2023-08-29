#Valentino Jaya Lay
#TP062964

# Main start

def Main_menu():
    print("Hello Wellcome to The Maymobile")
    print("*** May your life be good ***")
    print("===============================")

    while True:
        Askuser = input("do you have any account yet? (y/n) or do you want to exit? (input e)")
        if Askuser == "y":
            logon_menu()
            break
        elif Askuser == "n":
            registeraccount()
            break
        else:
            if Askuser == "yes":
                logon_menu()
                break
            elif Askuser == "no":
                registeraccount()
                break
            elif Askuser == "e":
                print("Have A G'day")
                print("May the wind shows the way")
                exit()
            else:
                print("can you plese cheeck again")



def logon_menu():  # call out function
    checkinguser = True
    counter = 0
    Count = 0 - 1
    while checkinguser == True:
        username = input("please enter username: ")
        with open("Database.txt", "r") as fh1:
            for rec in fh1:
                userread = rec.split(";")
                Count = 1 + Count
                if username == userread[0]:
                    nameuser1 = userread[0]
                    userpass = userread[1]
                    account_type = userread[2]
                    Namename = userread[3]
                    datebirth = userread[4]
                    emailuser1 = userread[5]
                    phonenumuser1 = userread[6]
                    accounttype = userread[7]
                    balance = userread[8]
                    checkinguser = False
                    passwordcheck(nameuser1, userpass, account_type, Namename, datebirth, emailuser1, phonenumuser1,
                                  accounttype, balance, Count)  # Password is already called out
                    break  # break from reality (loop I mean)

        if checkinguser == False:
            break
        else:
            print("Thats not right, can you check again?")
            counter = counter + 1
            if counter == 5:
                print("sorry thats too much attempt")
                Main_menu()


# ============================================================

def passwordcheck(nameuser1, userpass, account_type, Namename, datebirth, emailuser1, phonenumuser1, accounttype,
                  balance, Count):
    checker = 0
    cnt = 0
    while checker == 0:
        passuser = input("please enter password: ")
        if userpass == passuser:
            accountautho(nameuser1, userpass, account_type, Namename, datebirth, emailuser1, phonenumuser1, accounttype,
                         balance, Count)
            break
        else:
            print("That pass is suspicious, can you check again?")
            cnt = cnt + 1
            if cnt == 5:  # this if will make the 5th attempt kick user out
                print("thats too much attempt please log in again ")
                Main_menu()
                break


# ============================================================

def accountautho(nameuser1, userpass, account_type, Namename, datebirth, emailuser1, phonenumuser1, accounttype,
                 balance, Count):
    if account_type == "S":
        print("=============================")
        print("    ")
        print("Welcome Admin Super account")
        print("    ")
        print("=============================")
        adminprogram()
    elif account_type == "A":

        staff_program()

    elif account_type == "B":

        print("=============================")
        print("    ")
        print("Welcome User " + Namename)
        print("    ")
        print("=============================")
        user_program(nameuser1, userpass, account_type, Namename, datebirth, emailuser1, phonenumuser1, accounttype, balance, Count)


# ============================================================

def adminprogram():
    checkingcode1 = 1
    while checkingcode1 == 1:
        print("=" * 20)
        print("1 wish to edit admin account")
        print("2 Add admin account?")
        print("3 to log out")
        adminauthoritycode = input("Code: ")
        if adminauthoritycode == "1":
            print("what do wish to edit admin account")
            edit_datasuperaccount()
            checkingcode1 == 0
            break
        elif adminauthoritycode == "2":
            print("Add admin account?")
            Addaccountadmin()
            checkingcode1 == 0
            break
        elif adminauthoritycode == "3":
            print("OK got it")
            checkingcode1 == 0
            Main_menu()
            break

        else:
            print("please enter from the number above")


# ============================================================

def edit_datasuperaccount():
    print("===============================================================================")
    print("please see which account you want to edit with the correct username")
    print("please keep in mind that the constumer's data with label B cannot be edit")
    print("================================================================================")
    fh3 = open("Database.txt", "r")
    for rec in fh3:
        userread1 = rec.split(";")
        Usershow = userread1[0]
        print(Usershow)
    fh3.close()
    cnt = 0 - 1
    checkinguser = True
    while checkinguser == True:
        username = input("please enter username: ")
        fh4 = open("Database.txt", "r")
        for rec in fh4:
            cnt = 1 + cnt
            userread2 = rec.split(";")
            if username == userread2[0]:
                username2 = userread2[0]
                userpass2 = userread2[1]
                authority = userread2[2]

                Authority_user(cnt, authority, username2, userpass2)
                fh4.close()
                checkinguser = False
                break

        if checkinguser == False:
            break
        else:
            print("Thats not right, can you check again?")


# ============================================================

def Authority_user(cnt, authority, username2, userpass2):
    if authority == "A":
        print("===============================")
        superaccountedit(cnt, username2, userpass2)
    elif authority == "S":
        print("you cannot edit you own account no?")
        edit_datasuperaccount()
    elif authority == "B":
        print("you cannot edit costumer account")
        edit_datasuperaccount()
    else:
        print("please check again")


# ============================================================

def superaccountedit(cnt, username2, userpass2):
    useradmincode = "A"
    fh4 = open("Database.txt", "r")
    list_line = fh4.readlines()
    checkcheckcheck1 = True
    fh4.close()
    while checkcheckcheck1 == True:
        selection_question = input("Please input number which one you want to edit, username as 1 while password as 2:  ")
        accounttype = "R"
        num1 = "0"
        if selection_question == "1":
            useradmin = input("the admin username:  ")
            nodata = "checknon"
            list_line[cnt] = f'{useradmin};{userpass2};{useradmincode};{useradmin};{nodata};{nodata};{nodata};{accounttype};{num1}\n'
            fh5 = open("Database.txt", "w")
            fh5.writelines(list_line)
            fh5.close()
            checkcheckcheck1 = False
            adminprogram()
            break
        elif selection_question == "2":
            useradminpassword = input("The user admin password:  ")
            nodata = "checknon"
            list_line[
                cnt] = f'{username2};{useradminpassword};{useradmincode};{username2};{nodata};{nodata};{nodata};{accounttype};{num1}\n'
            fh5 = open("Database.txt", "w")
            fh5.writelines(list_line)
            fh5.close()
            checkcheckcheck1 = False
            adminprogram()
            break

        else:
            print("please check again")


# =================================================


def Addaccountadmin():
    useradmincode1 = "A"
    print("please input the necessary information below")
    fh6 = open("Database.txt", "a")
    username3 = input("Username: ")
    password3 = input("Password: ")
    nodata = "checknon"
    accounttype = "A"
    num1 = "0"
    list_line2 = f'{username3};{password3};{useradmincode1};{username3};{nodata};{nodata};{nodata};{accounttype};{num1}\n'
    fh6.write(list_line2)
    fh6.close()
    adminprogram()


# =================================================
def registeraccount():
    print("Hello, Wellcome new user! please fill the questions below")
    while True:
        user1name = input("Name: ")
        dayofbirth = input("Birthday? dd/mm/yy ")
        email = input("Email: ")
        phonenum = input("Phone: ")
        accounttype = input("what is your account type? current/saving (c/s)")

        if accounttype == "c":
            askusercheck = input("are you sure all of the information is correct? (y/n)")
            if askusercheck == "y":
                adddata(user1name, dayofbirth, email, phonenum, accounttype)
                break
            elif askusercheck == "n":
                pass
            elif askusercheck == "yes":
                adddata(user1name, dayofbirth, email, phonenum, accounttype)
                break
            elif askusercheck == "no":
                pass
            else:
                print("please check your answer again")
        elif accounttype == "s":
            askusercheck = input("are you sure all of the information is correct? (y/n)")
            if askusercheck == "y":
                adddata(user1name, dayofbirth, email, phonenum, accounttype)
                break
            elif askusercheck == "n":
                pass
            elif askusercheck == "yes":
                adddata(user1name, dayofbirth, email, phonenum, accounttype)
                break
            elif askusercheck == "no":
                pass
            else:
                print("please check your answer again")

        else:
            print("there is no such a thing as " + accounttype)


def adddata(user1name, dayofbirth, email, phonenum, accounttype):
    fh7 = open("Newaccount.txt", "a")
    linelist1 = f'{user1name};{dayofbirth};{email};{phonenum};{accounttype};\n'
    fh7.write(linelist1)
    fh7.close()
    Main_menu()


# =================================================

def staff_program():
    print("=======================================")
    print("Wellcome Admin")
    print("What do you want to do today?")
    print("=======================================")
    while True:
        staffautho = input(
            "To add registration, please input 1, to change information about user data, press 2, To log out press 3. 4 for printing report: ")
        if staffautho == "1":
            print("which account you want to approve?")
            approval()
            break
        elif staffautho == "2":
            print("which user account you want to change user account")
            changeuser()
            break
        elif staffautho == "3":
            print("ok got it, have a nice day")
            Main_menu()
            break
        elif staffautho == "4":
            printreportadmin()
        else:
            print("check your input again")


# =================================================

def approval():
    fh8 = open("Newaccount.txt", "r")
    for rec in fh8:
        userread4 = rec.split(";")
        Usershow = userread4[0]
        print(Usershow)
    fh8.close()
    checkinguser = True
    while checkinguser == True:
        account = input("which profile you want to approve? ")
        with open("Newaccount.txt", "r") as fh9:
            counter1 = 0 - 1
            for rec in fh9:
                userread3 = rec.split(";")
                counter1 = 1 + counter1
                if account == userread3[0]:
                    nameuser = userread3[0]
                    userbirth = userread3[1]
                    useremail = userread3[2]
                    userphonenum = userread3[3]
                    usertype = userread3[4]
                    print(usertype)
                    check_approval(nameuser, userbirth, useremail, userphonenum, counter1, usertype)

                    checkinguser = False
                    break

        if checkinguser == False:
            break
        else:
            print("please check the new client again")


def check_approval(nameuser, userbirth, useremail, userphonenum, counter1, usertype):
    with open("Database.txt", "r") as fh11:
        cnt = 0
        if usertype == "s":
            balance = float(100)
            for rec in fh11:
                cnt = cnt + 1
            cnt = str(cnt)
            fh10 = open("Database.txt", "a")
            username4 = "user" + cnt.zfill(4)
            password4 = cnt.zfill(4)
            usercode1 = "B"
            list_line3 = f'{username4};{password4};{usercode1};{nameuser};{userbirth};{useremail};{userphonenum};{usertype};{balance}\n'
            fh10.write(list_line3)
            fh10.close()

            # this below for deleting data
            fh12 = open("Newaccount.txt", "r")
            list_line = fh12.readlines()
            list_line[counter1] = f''
            fh12.close()
            fh13 = open("Newaccount.txt", "w")
            fh13.writelines(list_line)
            fh13.close()
            print("Save account")
            import datetime as myDate
            now_date = myDate.datetime.now()
            now_date = now_date.strftime('%Y-%m-%d; at %H:%M:%S')

            createinfo = "Create"
            createinfo2 = "start with 100 ringgit"
            with open("record.txt", "a") as fhrecord:
                linelistrecord = f'{createinfo};{now_date};{nameuser};{createinfo2}\n'
                fhrecord.write(linelistrecord)

        elif usertype == "c":
            balance = float(500)
            for rec in fh11:
                cnt = cnt + 1
            cnt = str(cnt)
            fh10 = open("Database.txt", "a")
            username4 = "user" + cnt.zfill(4)
            password4 = cnt.zfill(4)
            usercode1 = "B"
            list_line3 = f'{username4};{password4};{usercode1};{nameuser};{userbirth};{useremail};{userphonenum};{usertype};{balance}\n'
            fh10.write(list_line3)
            fh10.close()

            # this below for deleting data
            fh12 = open("Newaccount.txt", "r")
            list_line = fh12.readlines()
            list_line[counter1] = f''
            fh12.close()
            fh13 = open("Newaccount.txt", "w")
            fh13.writelines(list_line)
            fh13.close()
            print("Current account")
            import datetime as myDate
            now_date = myDate.datetime.now()
            now_date = now_date.strftime('%Y-%m-%d; at %H:%M:%S')

            createinfo = "Create"
            createinfo2 = "start with 500 ringgit"
            with open("record.txt", "a") as fhrecord:
                linelistrecord = f'{createinfo};{now_date};{nameuser};{createinfo2}\n'
                fhrecord.write(linelistrecord)

    staff_program()

# =============================================================

def changeuser():
    print("===============================================================================")
    print("please see which account you want to edit with the correct username")
    print("please keep in mind that admin could only edit user account")
    print("================================================================================")
    fh14 = open("Database.txt", "r")
    for rec in fh14:
        userread6 = rec.split(";")
        Usershow = userread6[3]
        print(Usershow)
    fh14.close()
    cnt = 0 - 1
    checkinguser = True
    while checkinguser == True:
        username = input("please enter his/her name: ")
        fh15 = open("Database.txt", "r")
        for rec in fh15:
            cnt = 1 + cnt
            userread7 = rec.split(";")
            if username == userread7[3]:
                usernumaccount = userread7[0]
                userpass2 = userread7[1]
                authority1 = userread7[2]
                nameuser1 = userread7[3]
                datebirthchange = userread7[4]
                emailchange = userread7[5]
                phonnumuser = userread7[6]
                accounttype = userread7[7]
                balance = userread7[8]
                Authority_user_check(cnt, authority1, usernumaccount, userpass2, nameuser1, datebirthchange,
                                     emailchange, phonnumuser, accounttype, balance)
                fh15.close()
                checkinguser = False
                break

        if checkinguser == False:
            break
        else:
            print("Thats not right, can you check again?")


def Authority_user_check(cnt, authority1, usernumaccount, userpass2, nameuser1, datebirthchange, emailchange,
                         phonnumuser, accounttype, balance):
    if authority1 == "B":
        print("===============================")
        changeuser1(cnt, authority1, userpass2, usernumaccount, nameuser1, datebirthchange, emailchange, phonnumuser,
                    accounttype, balance)
    elif authority1 == "A":
        print("you cannot edit you own account no?")
        changeuser()
    elif authority1 == "S":
        print("you cannot edit your superior!")
        changeuser()
    else:
        print("please check again")


def changeuser1(cnt, authority1, userpass2, usernumaccount, nameuser1, datebirthchange, emailchange, phonnumuser,
                accounttype, balance):
    repeater = True
    while repeater == True:
        selection_question = input("Please input number which one you want to edit, "
                                   "1 for password, 2 for client name information change "
                                   "3 for client's birthdate, 4 client's email, 5, client's phone number "
                                   "6 change client's account type:  ")
        fh16 = open("Database.txt", "r")
        list_line = fh16.readlines()
        fh16.close()

        if selection_question == "1":
            data_change = input("password:  ")
            list_line[
                cnt] = f'{usernumaccount};{data_change};{authority1};{nameuser1};{datebirthchange};{emailchange};{phonnumuser};{accounttype};{balance}\n'
            fh17 = open("Database.txt", "w")
            fh17.writelines(list_line)
            fh17.close()


        elif selection_question == "2":
            data_change = input("Name:  ")
            list_line[
                cnt] = f'{usernumaccount};{userpass2};{authority1};{data_change};{datebirthchange};{emailchange};{phonnumuser};{accounttype};{balance}\n'
            fh17 = open("Database.txt", "w")
            fh17.writelines(list_line)
            fh17.close()

        elif selection_question == "3":
            data_change = input("dd/mm/yy:  ")
            list_line[
                cnt] = f'{usernumaccount};{userpass2};{authority1};{nameuser1};{data_change};{emailchange};{phonnumuser};{accounttype};{balance}\n'
            fh17 = open("Database.txt", "w")
            fh17.writelines(list_line)
            fh17.close()

        elif selection_question == "4":
            data_change = input("email:  ")
            list_line[
                cnt] = f'{usernumaccount};{userpass2};{authority1};{nameuser1};{datebirthchange};{data_change};{phonnumuser};{accounttype};{balance}\n'
            fh17 = open("Database.txt", "w")
            fh17.writelines(list_line)
            fh17.close()

        elif selection_question == "5":
            data_change = input("phone number:  ")
            list_line[
                cnt] = f'{usernumaccount};{userpass2};{authority1};{nameuser1};{datebirthchange};{emailchange};{data_change};{accounttype};{balance}\n'
            fh17 = open("Database.txt", "w")
            fh17.writelines(list_line)
            fh17.close()
        else:
            print("please check again")

        askagain = input(
            "would you like to change data again?(y/n) or you want to change data with different account? (d)")
        if askagain == "yes" or askagain == "y":
            pass
        elif askagain == "d":
            changeuser()
            break
        elif askagain == "no" or askagain == "n":
            staff_program()
            break
        else:
            print("please check again")


# ===============================================================
# ================================================================
def user_program(nameuser1, userpass, account_type, Namename, datebirth, emailuser1, phonenumuser1, accounttype, balance, Count):
    while True:
        if accounttype == "c":
            print("As a reminder, Current account must have 500 ringgit, or you cannot do any withdrawal")
            print(
                "input 1 for deposit, input 2 for withdraw, input 3 for check balance, input 4 changing password, input 5 for logout, 6 print file costumer statement report")
            askuser1 = input("Hello, What would you like to do?")
            if askuser1 == "1":
                deposit(nameuser1, userpass, account_type, Namename, datebirth, emailuser1, phonenumuser1, accounttype,
                        balance, Count)
                break
            elif askuser1 == "2":
                withdrawalcurrent(nameuser1, userpass, account_type, Namename, datebirth, emailuser1, phonenumuser1,
                                  accounttype, balance, Count)
                break
            elif askuser1 == "3":
                checkbalance(nameuser1, userpass, account_type, Namename, datebirth, emailuser1, phonenumuser1, accounttype, balance, Count)
                break
            elif askuser1 == "4":
                changepassword(nameuser1, userpass, account_type, Namename, datebirth, emailuser1, phonenumuser1, accounttype, balance, Count)
                break
            elif askuser1 == "5":
                Main_menu()
                break
            elif askuser1 == "6":
                printreport(Namename)
                exit()
            else:
                print("please check again")

        if accounttype == "s":
            print("As a reminder, Saving account must have 100 ringgit, or you cannot do any withdrawal")
            print(
                "input 1 for deposit, input 2 for withdraw, input 3 for check balance, input 4 changing password, input 5 for logout, 6 print file costumer statement report")
            print(
                "====================================================================================================")
            askuser1 = input("Hello, What would you like to do?")
            if askuser1 == "1":
                deposit(nameuser1, userpass, account_type, Namename, datebirth, emailuser1, phonenumuser1, accounttype, balance, Count)
                break
            elif askuser1 == "2":
                withdrawalsave(nameuser1, userpass, account_type, Namename, datebirth, emailuser1, phonenumuser1, accounttype, balance, Count)
                break
            elif askuser1 == "3":
                checkbalance(nameuser1, userpass, account_type, Namename, datebirth, emailuser1, phonenumuser1, accounttype, balance, Count)
                break
            elif askuser1 == "4":
                changepassword(nameuser1, userpass, account_type, Namename, datebirth, emailuser1, phonenumuser1, accounttype, balance, Count)
                break
            elif askuser1 == "5":
                Main_menu()
                break
            elif askuser1 == "6":
                printreport(Namename)
                exit()
            else:
                print("please check again")


# ==============================================================
def deposit(nameuser1, userpass, account_type, Namename, datebirth, emailuser1, phonenumuser1, accounttype, balance, Count):
    while True:
        print("how much do you want to deposit? :")
        try:
            deposit = float(input())
        except:
            print("please check again")
            continue

        balance = float(balance)
        total = balance + deposit

        fh19 = open("Database.txt", "r")
        list_line = fh19.readlines()
        fh19.close()

        list_line[Count] = f'{nameuser1};{userpass};{account_type};{Namename};{datebirth};{emailuser1};{phonenumuser1};{accounttype};{total}\n'
        fh20 = open("Database.txt", "w")
        fh20.writelines(list_line)
        fh20.close()

        import datetime as myDate
        now_date = myDate.datetime.now()
        now_date = now_date.strftime('Deposit;%Y-%m-%d; at %H:%M:%S')

        fh21 = open("record.txt", "a")
        linelist1 = f'{now_date};{deposit};{Namename};{total}\n'
        fh21.write(linelist1)
        fh21.close()

        user_program(nameuser1, userpass, account_type, Namename, datebirth, emailuser1, phonenumuser1, accounttype, total, Count)
        break


# ====================================================================================================

def withdrawalcurrent(nameuser1, userpass, account_type, Namename, datebirth, emailuser1, phonenumuser1, accounttype, balance, Count):
    print("please keep in mind that you cannot withdraw below 500 ringgit")
    while True:
        print("how much do you want to withdraw? :")
        try:
            withdrawal = float(input())
        except:
            print("please check again")
            continue

        balance = float(balance)
        total = balance - withdrawal

        if balance <= 500:
            print("sorry you cannot perform withdrawal")
        elif total <= 500:
            print("sorry you cannot perform withdrawal")
        elif total >= 500:
            fh19 = open("Database.txt", "r")
            list_line = fh19.readlines()
            fh19.close()

            list_line[Count] = f'{nameuser1};{userpass};{account_type};{Namename};{datebirth};{emailuser1};{phonenumuser1};{accounttype};{total}\n'
            fh20 = open("Database.txt", "w")
            fh20.writelines(list_line)
            fh20.close()

            import datetime as myDate
            now_date = myDate.datetime.now()
            now_date = now_date.strftime('Withdraw;%Y-%m-%d; at %H:%M:%S')

            with open("record.txt", "a") as fh21:
                linelist1 = f'{now_date};{withdrawal};{Namename};{total}\n'
                fh21.write(linelist1)

            user_program(nameuser1, userpass, account_type, Namename, datebirth, emailuser1, phonenumuser1, accounttype,total, Count)
            break


# ====================================================================================================

def withdrawalsave(nameuser1, userpass, account_type, Namename, datebirth, emailuser1, phonenumuser1, accounttype, balance, Count):
    print("please keep in mind that you cannot withdraw below 100 ringgit")
    while True:
        print("how much do you want to withdraw? :")
        try:
            withdrawal = float(input())
        except:
            print("please check again")
            continue

        balance = float(balance)
        total = balance - withdrawal

        if balance <= 100:
            print("sorry you cannot perform withdrawal")
        elif total <= 100:
            print("sorry you cannot perform withdrawal")
        elif total >= 500:
            fh19 = open("Database.txt", "r")
            list_line = fh19.readlines()
            fh19.close()
            list_line[
                Count] = f'{nameuser1};{userpass};{account_type};{Namename};{datebirth};{emailuser1};{phonenumuser1};{accounttype};{total}\n'
            fh20 = open("Database.txt", "w")
            fh20.writelines(list_line)
            fh20.close()

            import datetime as myDate
            now_date = myDate.datetime.now()
            now_date = now_date.strftime('Withdraw;%Y-%m-%d; at %H:%M:%S')

            with open("record.txt", "a") as fh21:
                linelist1 = f'{now_date};{withdrawal};{Namename};{total}\n'
                fh21.write(linelist1)

        user_program(nameuser1, userpass, account_type, Namename, datebirth, emailuser1, phonenumuser1, accounttype, balance, Count)


# ====================================================================================================

def checkbalance(nameuser1, userpass, account_type, Namename, datebirth, emailuser1, phonenumuser1, accounttype, balance, Count):
    if accounttype == "c":
        print("Hello "+Namename)
        print("Check balance for Current account")
        print(balance)

    elif accounttype == "s":
        print("Hello"+Namename)
        print("Check balance for Saving account")
        print(balance)




    user_program(nameuser1, userpass, account_type, Namename, datebirth, emailuser1, phonenumuser1, accounttype, balance, Count)


def changepassword(nameuser1, userpass, account_type, Namename, datebirth, emailuser1, phonenumuser1, accounttype, balance, Count):
    fh23 = open("Database.txt", "r")
    list_line = fh23.readlines()
    fh23.close()

    while True:
        password = input("New Password:")
        askagain = input("Are you sure?")
        if askagain == "y":
            list_line[Count] = f'{nameuser1};{password};{account_type};{Namename};{datebirth};{emailuser1};{phonenumuser1};{accounttype};{balance}\n'
            fh24 = open("Database.txt", "w")
            fh24.writelines(list_line)
            fh24.close()
            print("please re open the software")
            exit()
        elif askagain == "yes":
            list_line[
                Count] = f'{nameuser1};{password};{account_type};{Namename};{datebirth};{emailuser1};{phonenumuser1};{accounttype};{balance}\n'
            fh25 = open("Database.txt", "w")
            fh25.writelines(list_line)
            fh25.close()
            print("please re open the software")
            exit()
        elif askagain == "n":
            print("please check again")

        elif askagain == "no":
            print("please check again")
        else:
            print("please check again!")

#=====================================================================
#create a report
def printreportadmin():
    while True:
        with open("Database.txt", "r") as fh:
            for rec in fh:
                userreaduser = rec.split(";")
                Usershow = userreaduser[3]
                authoautho = userreaduser[2]
                if authoautho == "B":
                    print(Usershow)

        with open("Database.txt", "r") as fh1:
            account = input("which profile you want to check? ")
            for rec1 in fh1:
                checkinguser = False
                nameuserread = rec1.split(";")
                nameuser = nameuserread[3]
                if account == nameuser :
                    printprint(account)
                    checkinguser = True
            if checkinguser == True:
                pass
            elif checkinguser == False:
                print("please check again")

def printprint(account):
    with open("record.txt", "r") as filerecord:
        for rec2 in filerecord:
            nameread = rec2.split(";")
            name = nameread[4]
            if name == account:
                check = nameread[0]
                date = nameread[1]
                time = nameread[2]
                amount = nameread[3]
                balance = nameread[5]
                print(check + " " + date + " " + time + ", amount= " + amount + " balance=" + balance)

    staff_program()

#=========================================================
def printreport(Namename):
    while True:
        askuser = input("from what date? (yyyy-mm-dd)")
        askuser2 = input("To what date? (yyyy-mm-dd)")
        check = False
        with open("record.txt","r") as fileread:
            for rec in fileread:
                datedata = rec.strip().split(";")
                if Namename == datedata[4]:
                    datatime1 = datedata[1]
                    datatime11 = datatime1.strip().split("-")
                    yeardata = int(datatime11[0])
                    monthdata = int(datatime11[1])
                    daydata = int(datatime11[2])
                    ansuser = askuser.strip().split("-")
                    ansuser2 = askuser2.strip().split(("-"))

                    action = datedata[0]
                    balance = datedata[5]
                    try:
                        year1 = int(ansuser[0])
                        year2 = int(ansuser2[0])
                        month1 = int(ansuser[1])
                        month2 = int(ansuser2[1])
                        day1 = int(ansuser[2])
                        day2 = int(ansuser2[2])
                    except:
                        continue

                    if year1 < yeardata and year2 > yeardata:
                        print(datatime1 + " " + action + " " + balance)
                        check = True
                    elif year1 <= yeardata and year2 >= yeardata and month1 < monthdata and month2 > monthdata:
                        print(datatime1 + " " + action + " " + balance)
                        check = True
                    elif year1 <= yeardata and year2 >= yeardata and month1 <= monthdata and month2 >= monthdata and day1 < daydata and day2 > daydata:
                        print(datatime1 + " " + action + " " + balance)
                        check = True
                    elif year1 <= yeardata and year2 >= yeardata and month1 <= monthdata and month2 >= monthdata and day1 <= daydata and day2 >= daydata:
                        print(datatime1 + " " + action + " " + balance)
                        check = True
                    elif year1 <= yeardata and year2 >= yeardata and month1 < monthdata and month2 > monthdata and day1 <= daydata and day2 >= daydata:
                        print(datatime1 + " " + action + " " + balance)
                        check = True
                    elif year1 <= yeardata and year2 >= yeardata and month1 < monthdata and month2 > monthdata and day1 <= daydata and day2 >= daydata:
                        print(datatime1 + " " + action + " " + balance)
                        check = True
                    else:
                        print("It seems that there are no data please check carefully on the dates, sorry you must re log again")


        if check == True:
            while True:
                print("please Re open the application")
                askask = input("are you sure you have read the history?")
                if askask == "yes":
                    exit()
                elif askask == "no":
                    print("ok")
        else:
            print("please check again")
            pass



#=====================================================================
#execution
#MAIN LOGIC!

Main_menu()


